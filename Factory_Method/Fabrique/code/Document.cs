/**
 * Author : B.SILKA
 * Date : 01.02.18
 * Description : Design pattern FabricMethod
 * Inpired of : http://www.dofactory.com/net/factory-method-design-pattern
 **/
using System.Collections.Generic;

namespace Factory_Method
{
    //{ BeginList }
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }
    //{ EndList }
}
