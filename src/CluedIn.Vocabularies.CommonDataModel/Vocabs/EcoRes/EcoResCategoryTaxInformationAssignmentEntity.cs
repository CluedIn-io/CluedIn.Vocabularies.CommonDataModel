using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResCategoryTaxInformationAssignmentEntityVocabulary : SimpleVocabulary
    {
        public EcoResCategoryTaxInformationAssignmentEntityVocabulary()
        {
            VocabularyName = "Eco Res Category Tax Information Assignment Entity";
            KeyPrefix = "commonDataModel.ecorescategorytaxinformationassignmententity";
            KeySeparator = ".";
            Grouping = "/EcoResCategoryTaxInformationAssignmentEntity";

            AddGroup("EcoResCategoryTaxInformationAssignmentEntity Details", group =>
            {
                Exempt = group.Add(new VocabularyKey(nameof(Exempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonGST = group.Add(new VocabularyKey(nameof(NonGST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HSNCode = group.Add(new VocabularyKey(nameof(HSNCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAccountingCode = group.Add(new VocabularyKey(nameof(ServiceAccountingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRateTypeName = group.Add(new VocabularyKey(nameof(TaxRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Exempt { get; private set; }
        public VocabularyKey NonGST { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey HSNCode { get; private set; }
        public VocabularyKey ServiceAccountingCode { get; private set; }
        public VocabularyKey TaxRateTypeName { get; private set; }
    }
}