const express = require('express');
const app = express();
const bodyParser = require('body-parser');
const port = 3001; // The default port is 3000, but there is already used in React.JS App
const sql = require('mssql');

// Initiallising connection string
let connStr = {
    user: "****",
    password: "********",
    server: "***.***.***.***",
    database: "Etherchain",
    "options": {
        "encrypt": true,
        "enableArithAbort": true
    },
};

// Making the connection with the MS SQL Database
sql.connect(connStr)
    .then(conn => global.conn = conn)
    .catch(err => console.log(err));

app.use(bodyParser.urlencoded({
    extended: true
}));

app.use(bodyParser.json());

// Default router with a return of defined values to say if the API has working.
const router = express.Router();
router.get('/', (req, res) => res.json({
    message: "A API está funcionando."
}));
app.use('/', router);

app.listen(port);
console.log(`API Funcionando! \nDATABASE: ${connStr.database}\nPORT: ${port}`);

function execSQLQuery(sqlQry, res) {
    global.conn.request()
        .query(sqlQry)
        .then(result => res.json(result.recordset))
        .catch(err => res.json(err));
}

router.get('/employee', (req, res) => {
    execSQLQuery('SELECT * FROM EMPLOYEE', res);
});

router.get('/employee/:id', (req, res) => {
    let filter = '';
    if (req.params.id) filter = ` WHERE ID = ${parseInt(req.params.id)}`;

    execSQLQuery('SELECT * FROM EMPLOYEE' + filter, res);
});