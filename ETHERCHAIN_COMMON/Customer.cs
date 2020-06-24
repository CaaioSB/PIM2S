using caiosb.SqlMaster.Command;
using caiosb.Util.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    public class Customer
    {
        private int _customerId;
        private string _email;
        private string _words;
        private string _wordsLanguage;
        private string _country;
        private string _streetLine;
        private string _city;
        private string _region;
        private string _postCode;
        private string _mobileNumber;

        public int CustomerId { get => _customerId; set => _customerId = value; }
        public string Email { get => _email; set => _email = value; }
        public string Words { get => _words; set => _words = value; }
        public string WordsLanguage { get => _wordsLanguage; set => _wordsLanguage = value; }
        public string Country { get => _country; set => _country = value; }
        public string StreetLine { get => _streetLine; set => _streetLine = value; }
        public string City { get => _city; set => _city = value; }
        public string Region { get => _region; set => _region = value; }
        public string PostCode { get => _postCode; set => _postCode = value; }
        public string MobileNumber { get => _mobileNumber; set => _mobileNumber = value; }
    }
}
