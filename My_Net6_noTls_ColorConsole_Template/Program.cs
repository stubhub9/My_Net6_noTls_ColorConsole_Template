namespace My_Net6_noTls_ColorConsole_Template
{
    //  Net6 version Seems to be compatable with Net4.7 Framework [OCT2024]
    

    internal class Program
    {
        #region  Fields and Properties
        //  Gets the original background [black], for reset on close.
        static readonly ConsoleColor originalBgColor = Console.BackgroundColor;

        /*  Can be set to any color between Black 0 & White 15; 
         *  the terminal's background will be the next color. 
        Black  0, 
          Blue9, Cyan11, Gray7, Green10, Magenta13, Red12, Yellow14 
        Dark+   
          Blue1, Cyan3, Gray8, Green2, Magenta5, Red4, Yellow6 
        White  15*/
        static ConsoleColor _newColor = ConsoleColor.DarkRed;

        /// <summary>
        ///  Can be set to any color between Black 0 & LESS THAN White 15; 
        ///  the terminal or row background will be the next color.
        /// </summary>
        public static ConsoleColor NewColor
        {
            get
            {
                _newColor++;

                if (_newColor == ConsoleColor.White)
                {
                    _newColor = ConsoleColor.DarkBlue;
                }
                return _newColor;
            }
            set
            {
                if (((ConsoleColor)0 <= value) && (value < (ConsoleColor)15))
                {

                    //  If between Black and White, then set value as current color enum;
                    //  with +1 on next get. 
                    _newColor = value;
                }
            }
        }

        #endregion  Fields and Properties
        #region  Main Constructor

        //  Haven't figured out combining properties with TLS;
        //  [switch properties to methods; and just use the global, private vars].

        //  Give it to me like a constructor, instead of TopLevel statements Template.
        static void Main ( string [] args )
        {
            //  New terminal color
            Console.BackgroundColor = NewColor;
            Console.Clear ();
            //  New command line row background.
            Console.BackgroundColor = NewColor;




            Console.WriteLine ( "Hello, World!" );
            Console.ReadLine ();


        }
        #endregion  Main Constructor

    }
}