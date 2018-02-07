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
    class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());

            Pages.Add(new ResultsPage());

            Pages.Add(new ConclusionPage());

            Pages.Add(new SummaryPage());

            Pages.Add(new BibliographyPage());
        }
    }
    //{ EndList }
}
