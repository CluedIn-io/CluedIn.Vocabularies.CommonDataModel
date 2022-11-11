using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStaffEntityVocabulary : SimpleVocabulary
    {
        public RetailStaffEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailStaffEntity";
            KeyPrefix = "commonDataModel.retailstaffentity";
            KeySeparator = ".";
            Grouping = "/RetailStaffEntity";

            AddGroup("Common Data Model RetailStaffEntity Details", group =>
            {
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CultureName = group.Add(new VocabularyKey(nameof(CultureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalName = group.Add(new VocabularyKey(nameof(ExternalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalSubIdentifier = group.Add(new VocabularyKey(nameof(ExternalSubIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentType = group.Add(new VocabularyKey(nameof(EmploymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Image = group.Add(new VocabularyKey(nameof(Image), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameOnReceipt = group.Add(new VocabularyKey(nameof(NameOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalIdentityAlias = group.Add(new VocabularyKey(nameof(ExternalIdentityAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutId = group.Add(new VocabularyKey(nameof(LayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey CultureName { get; private set; }
        public VocabularyKey ExternalName { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSubIdentifier { get; private set; }
        public VocabularyKey EmploymentType { get; private set; }
        public VocabularyKey Image { get; private set; }
        public VocabularyKey NameOnReceipt { get; private set; }
        public VocabularyKey ExternalIdentityAlias { get; private set; }
        public VocabularyKey LayoutId { get; private set; }


    }
}