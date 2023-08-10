namespace MudBlazor
{
    public class A 
    {
        public string Prop1 { get; set; }

        public int Prop2 { get; set; }
    }


    public class Test
    {
        public Test()
        {
            var x = new A();

            var fx = (A y) => y.Prop1;   
        }
    }

}

