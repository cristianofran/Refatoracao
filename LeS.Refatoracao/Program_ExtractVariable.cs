namespace LeS.Refatoracao
{
    class Program_ExtractVariable
    {
        static void Main(string[] args)
        {
        }

        private string platform;
        private int resize;
        
        void RenderBanner_Before()
        {
            if (platform.ToUpper().IndexOf("MAC") > -1
                && platform.ToUpper().IndexOf("IE") > -1
                && wasInitialized() 
                && resize > 0)
            {
                // code
            }
        }

        void RenderBanner_After()
        {
            var isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
            var isIE = platform.ToUpper().IndexOf("IE") > -1;
            var wasResized = resize > 0;

            if (isMacOs && isIE && wasInitialized() && wasResized)
            {
                // code
            }
        }

        private bool wasInitialized()
        {
            return true;
        }
    }
}
