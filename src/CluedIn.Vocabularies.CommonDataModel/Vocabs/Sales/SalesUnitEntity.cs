using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesUnitEntityVocabulary : SimpleVocabulary
    {
        public SalesUnitEntityVocabulary()
        {
            VocabularyName = "Sales Unit Entity";
            KeyPrefix = "commonDataModel.salesunitentity";
            KeySeparator = ".";
            Grouping = "/SalesUnitEntity";

            AddGroup("SalesUnitEntity Details", group =>
            {
                UnitId = group.Add(new VocabularyKey(nameof(UnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitDescription = group.Add(new VocabularyKey(nameof(UnitDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentSalesUnitId = group.Add(new VocabularyKey(nameof(ParentSalesUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey UnitId { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey UnitDescription { get; private set; }
        public VocabularyKey ParentSalesUnitId { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
    }
}