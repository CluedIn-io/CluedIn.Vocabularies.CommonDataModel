using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductEntityIdentifierScopeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductEntityIdentifierScopeEntityVocabulary()
        {
            VocabularyName = "EcoResProductEntityIdentifierScopeEntity";
            KeyPrefix = "commonDataModel.ecoresproductentityidentifierscopeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductEntityIdentifierScopeEntity";

            AddGroup("EcoResProductEntityIdentifierScopeEntity Details", group =>
            {
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodeId = group.Add(new VocabularyKey(nameof(CodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodeType = group.Add(new VocabularyKey(nameof(CodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroup = group.Add(new VocabularyKey(nameof(CustomerGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroup = group.Add(new VocabularyKey(nameof(VendorGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey CodeId { get; private set; }
        public VocabularyKey CodeType { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey CustomerGroup { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey VendorGroup { get; private set; }


    }
}