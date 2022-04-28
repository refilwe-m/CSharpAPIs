namespace CoffeeShop.Pub
{
    public class Publisher
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            //Check if OnChange Action is set before invoking it
            if (OnChange != null)
            {
                //Invoke OnChange Action
                OnChange();
            }
        }
    }
}