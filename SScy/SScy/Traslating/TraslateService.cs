using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SScy.Traslating
{
    class TraslateService
    {
        public static string languageittxt { get; set; } = "";
        public static string languageentxt { get; set; } = "";
        public static string button1Text { get; set; } = "";
        public static string codesscytext1 { get; set; } = "";
        public static string infotext1 { get; set; } = "";

        /// <summary>
        /// English Traslate. (ENGLISH)
        /// </summary>
        public static void ToEn()
        {
            // Traslate in ENGLISH (ENGLISH).

            languageittxt = "ITALIAN";
            languageentxt = "ENGLISH";
            button1Text = "REQUEST CONNECTION";
            codesscytext1 = "Your SScy code:";
            infotext1 = "This code allows other users to connect to you to perform HACK checks!";

        }


        /// <summary>
        /// Italian Traslate. (ITALIANO)
        /// </summary>
        public static void ToIT()
        {
            // Traslate in ITALIAN (ITALIANO).

            languageittxt = "ITALIANO";
            languageentxt = "INGLESE";
            button1Text = "RICHIEDI LA CONNESSIONE";
            codesscytext1 = "Il tuo codice SScy:";
            infotext1 = "Questo codice permette ad altri utenti di connettersi a te per eseguire controlli HACK !";

        }
    }
}
