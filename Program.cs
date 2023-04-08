namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; //1 byte
            sbyte sb = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte ̰

            Int16 i16 = 2; // 2 byte
            int i = 2; // 4 byte
            Int32 i132 = 2; // 4 byte
            Int64 i164 = 2; // 8 byte
            uint ui = 2; // 4 byte

            long l = 4; // 8 byte
            ulong ul = 4; // 8 byte

            //Reel Sayilar

            float f = 5; // 4byte
            double d = 5; //8byte
            decimal de = 5; // 16byte

            char ch = '2'; // 2byte
            string str = "Alper"; //sinirsiz

            bool b1 = false;
            bool b2 = true;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);


            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // String Ifadeler

            string str1 = string.Empty;
            str1 = "Alper Çelik";
            string ad = "Alper";
            string soyad = "Çelik";
            string tamIsim = ad + " " + soyad;

            //integer Tanimlama Sekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10 > 2;

            // Degisken Donusumleri 

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}