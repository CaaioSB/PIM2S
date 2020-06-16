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

const sql = require("mssql");

sql.connect(connStr)
    .then(conn => console.log("Conexão com o banco de dados realizada com sucesso!"))
    .catch(err => console.log("Houve um erro ao realizar a conexão com o banco de dados: " + err));