namespace _01_Cook
{
    public class Vegetable
    {
        private bool isPeeled = false;
        private bool isCut = false;

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                value = this.isPeeled;
            }
        }

        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                value = this.isCut;
            }
        }
    }
}
