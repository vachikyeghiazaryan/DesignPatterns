namespace FacadeNS
{
    public class Facade
    {
        private SubSystem1 _subSystem1 = new SubSystem1();
        private SubSystem2 _subSystem2 = new SubSystem2();
        private SubSystem3 _subSystem3 = new SubSystem3();
        private SubSystem4 _subSystem4 = new SubSystem4();

        public void MethodAB()
        {
            _subSystem1.MethodA();
            _subSystem2.MethodB();
        }

        public void MethodCD()
        {
            _subSystem3.MethodC();
            _subSystem4.MethodD();
        }
    }
}