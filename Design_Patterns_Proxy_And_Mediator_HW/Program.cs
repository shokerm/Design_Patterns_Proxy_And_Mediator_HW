using System;

namespace Design_Patterns_Proxy_And_Mediator_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proxy
            InteriorOffice interiorOffice = new InteriorOffice();
            interiorOffice.AdressUpdate();
            interiorOffice.LegalDepartment();

            Console.WriteLine("*************");
            CitizenProxy c1 = new CitizenProxy(interiorOffice);
            c1.AdressUpdate();

            OfficialProxy o1 = new OfficialProxy(interiorOffice);
            o1.FinanceDepartment();

            #endregion

            #region Mediator
            IFacebookGroup mediator = new FacebookGroup();
            Member m1 = new Member("Moshe", mediator);
            Member m2 = new Member("Dan", mediator);
            Member m3 = new Member("Yoav", mediator);
            Member m4 = new Member("Gili", mediator);
            mediator.RegisterUser(m1);
            mediator.RegisterUser(m2);
            mediator.RegisterUser(m3);
            mediator.RegisterUser(m4);

            m1.Publish("Hello i am Moshe");
            m2.Publish("Hello i am Dan");


            #endregion

        }
    }
}
