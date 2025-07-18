namespace Demo.UserDefinedDataTypes
{

    //what you can write inside?
    //1. class
    //2. interface
    //3. enum
    //4. struct

    //access modifer allowed inside?
    //1. public
    //2. internal (default)



    public class ClassA
    {
        //what you can write inside?
        //1. attribute => member variable
        //int X;
        //2. functions (constructor, getter , setter, method)
        //3. property (full prop, automatic prop, indexer)
        //int X { get; set; }
        //4. event


        //access modifier allowed inside?
        //1. public
        public int H;
        //2. private (default)
        private int X;
        //3. protected
        protected int Y;
        //4. internal
        internal int W;
        //5. protected internal
        protected internal int B;
        //6. private protected
        private protected int Z;

        void SetX(int value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
            B = value;
            H = value;
        }


    }
}
