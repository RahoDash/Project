/**
 * Author : B.SILKA
 * Date : 01.02.18
 * Description : Design pattern FabricMethod
 * Inpired of : http://www.dofactory.com/net/factory-method-design-pattern
 **/

namespace Factory_Method
{
    //{ BeginList }
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());

            Pages.Add(new EducationPage());

            Pages.Add(new ExperiencePage());
        }
    }
    //{ EndList }
}
