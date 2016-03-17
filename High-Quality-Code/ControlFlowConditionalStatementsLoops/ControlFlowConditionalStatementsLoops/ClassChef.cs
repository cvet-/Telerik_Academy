namespace ClassChef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();

            Potato potato = GetPotato();
            Potato peeledPotato = Peel(potato);
            Potato cutPotato = Cut(peeledPotato);
            bowl.Add(cutPotato);

            Carrot carrot = GetCarrot();
            Carrot peeledCarrot = Peel(carrot);
            Carrot cutCarrot = Cut(peeledCarrot);
            bowl.Add(cutCarrot);
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }

        private IVegetable Peel(IVegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private IVegetable Cut(IVegetable vegetable)
        {
            throw new NotImplementedException();
        }
    }
}