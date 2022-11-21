using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DiotDeclarationConceptEntityVocabulary : SimpleVocabulary
    {
        public DiotDeclarationConceptEntityVocabulary()
        {
            VocabularyName = "Diot Declaration Concept Entity";
            KeyPrefix = "commonDataModel.diotdeclarationconceptentity";
            KeySeparator = ".";
            Grouping = "/DiotDeclarationConceptEntity";

            AddGroup("DiotDeclarationConceptEntity Details", group =>
            {
                ConceptId = group.Add(new VocabularyKey(nameof(ConceptId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderNumber = group.Add(new VocabularyKey(nameof(OrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnType = group.Add(new VocabularyKey(nameof(ColumnType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nondeductible = group.Add(new VocabularyKey(nameof(Nondeductible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nondeductibleamount = group.Add(new VocabularyKey(nameof(Nondeductibleamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxName = group.Add(new VocabularyKey(nameof(TaxName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConceptId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OrderNumber { get; private set; }
        public VocabularyKey ColumnType { get; private set; }
        public VocabularyKey Nondeductible { get; private set; }
        public VocabularyKey Nondeductibleamount { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey TaxName { get; private set; }
    }
}