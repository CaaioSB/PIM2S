using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etherchain.Common
{
    class Wallet
    {
        private byte walletId;
        private byte addressId;
        private int qrCode;
        private string seed;
        private byte privateKey;
        private byte chainCode;
        private byte publicKey;
        private byte hash160;

        public byte WalletId { get => walletId; set => walletId = value; }
        public byte AddressId { get => addressId; set => addressId = value; }
        public int QrCode { get => qrCode; set => qrCode = value; }
        public string Seed { get => seed; set => seed = value; }
        public byte PrivateKey { get => privateKey; set => privateKey = value; }
        public byte ChainCode { get => chainCode; set => chainCode = value; }
        public byte PublicKey { get => publicKey; set => publicKey = value; }
        public byte Hash160 { get => hash160; set => hash160 = value; }

        public Wallet ObterPorWallet() { return new Wallet(); }
        public Wallet ObterPorAddress() { return new Wallet(); }
        public Wallet ObterPorQrCode() { return new Wallet(); }
        public Wallet ObterPorPublicKey() { return new Wallet(); }
        public bool Gravar() { return false; }
        public bool AlterarPorId() { return false; }
    }
}
