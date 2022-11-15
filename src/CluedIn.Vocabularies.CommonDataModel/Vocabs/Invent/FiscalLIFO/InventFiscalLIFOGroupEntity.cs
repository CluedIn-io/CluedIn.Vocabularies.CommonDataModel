using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventFiscalLIFOGroupEntityVocabulary : SimpleVocabulary
    {
        public InventFiscalLIFOGroupEntityVocabulary()
        {
            VocabularyName = "Invent Fiscal LIFO Group Entity";
            KeyPrefix = "commonDataModel.inventfiscallifogroupentity";
            KeySeparator = ".";
            Grouping = "/InventFiscalLIFOGroupEntity";

            AddGroup("InventFiscalLIFOGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIndividual = group.Add(new VocabularyKey(nameof(IsIndividual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NormalValue = group.Add(new VocabularyKey(nameof(NormalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NormalValueCalculation = group.Add(new VocabularyKey(nameof(NormalValueCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey IsIndividual { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NormalValue { get; private set; }
        public VocabularyKey NormalValueCalculation { get; private set; }
    }
}