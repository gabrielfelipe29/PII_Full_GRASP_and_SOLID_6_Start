namespace Full_GRASP_And_SOLID
{
    // Aplico ISP para que la clase Time pueda implementar el metodo TimeOut.
    // También aplico la ley de Demeter para ejecutar el metodo ChangeCookedToTrue de la Recipe que le 
    // paso como parametro.
    public class Time : TimerClient
    {
        public Recipe Recipe;


        public Time(Recipe recipe)
        {

            this.Recipe = recipe;

        }

        // Aplico Ley de Demeter para que cuando pase el tiempo del timer, ejecute el método TimeOut
        // y cambie Cooked a True.
        public void TimeOut()
        {

            Recipe.ChangeCookedToTrue();

        }

    }

}