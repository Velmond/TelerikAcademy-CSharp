namespace Cook
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Cut(Vegetable vegetable)
        {
            //...
        }

        private void Peel(Vegetable vegetable)
        {
            //...
        }

        public void Cook()
        {
            Bowl bowl = GetBowl();
            
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }
    }
}
