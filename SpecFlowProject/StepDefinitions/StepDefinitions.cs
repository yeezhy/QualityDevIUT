using Code.LibraryManager;
using Data.Code.Medias;
using TechTalk.SpecFlow.Assist;

namespace TestBDD.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition
    {
        private Library m_library;
        private Media m_MediaTest;
        private Media m_toCompare;

        [Given("Create library")]
        public void GivenCreateLibrary()
        {
            m_library = new Library();

        }

        [Given("Create this media : (.*)")]
        public void CreateMedia(Table p_table)
        {
            // Utilisation du Framework
            m_MediaTest = p_table.CreateInstance<Media>();
            // Autres (version manuelle)
            m_MediaTest = new Media();
            m_MediaTest.m_Titre = p_table.Rows[0]["m_Titre"].ToString();
            m_MediaTest.m_NumeroReference = Int32.Parse(p_table.Rows[0]["m_NumeroReference"]);
            m_MediaTest.m_NombreExemplairesDisponibles = Int32.Parse(p_table.Rows[0]["m_NombreExeplairesDisponibles"]);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            
        }
    }
}
