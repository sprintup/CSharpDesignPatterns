using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Practice
{
    class FactoryMethod_RealWorldPractice
    {
        public static void Run()
        {
            Console.WriteLine("Factory Method Real World Practice");
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
        //Product - defines the interface of object the factory method creates
        abstract class Page { }
        
        //Creator - 
        //1. declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreateProduct object.
        //2. may call the factory method to create a product object
        abstract class Document
        {
            private List<Page> _pages = new List<Page>();
            public List<Page> Pages
            {
                get { return _pages; }
            }
            public abstract void CreatePages();

            public Document()
            {
                this.CreatePages();
            }
        }
        
        //ConcreateCreator - overrides the factory method to return an instancce of a ConcreteProduct
        class Resume : Document
        {
            public override void CreatePages()
            {
                Pages.Add(new SkillsPage());
                Pages.Add(new EducationPage());
                Pages.Add(new ExperiencePage());
            }
        }
        
        //ConcreteProduct - implements the Product Interface
        class SkillsPage : Page { }
        class EducationPage : Page { }
        class ExperiencePage : Page { }

        class Report : Document
        {
            public override void CreatePages()
            {
                Pages.Add(new IntroductionPage());
                Pages.Add(new ResultsPage());
                Pages.Add(new ConclusionPage());
                Pages.Add(new SummaryPage());
                Pages.Add(new BibliographyPage());
            }
        }
        class IntroductionPage : Page { }
        class ResultsPage : Page { }
        class ConclusionPage : Page { }
        class SummaryPage : Page { }
        class BibliographyPage : Page { }
    }
}
