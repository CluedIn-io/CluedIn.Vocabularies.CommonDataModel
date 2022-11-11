using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsPostalAddressElectronicContactEntityVocabulary : SimpleVocabulary
    {
        public LogisticsPostalAddressElectronicContactEntityVocabulary()
        {
            VocabularyName = "LogisticsPostalAddressElectronicContactEntity";
            KeyPrefix = "commonDataModel.logisticspostaladdresselectroniccontactentity";
            KeySeparator = ".";
            Grouping = "/LogisticsPostalAddressElectronicContactEntity";

            AddGroup("LogisticsPostalAddressElectronicContactEntity Details", group =>
            {
                InternationalCallingCode = group.Add(new VocabularyKey(nameof(InternationalCallingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInstantMessage = group.Add(new VocabularyKey(nameof(IsInstantMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMobile = group.Add(new VocabularyKey(nameof(IsMobile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrivate = group.Add(new VocabularyKey(nameof(IsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Locator = group.Add(new VocabularyKey(nameof(Locator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Extension = group.Add(new VocabularyKey(nameof(Extension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalAddressLocationId = group.Add(new VocabularyKey(nameof(PostalAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InternationalCallingCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsInstantMessage { get; private set; }
        public VocabularyKey IsMobile { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey IsPrivate { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey Locator { get; private set; }
        public VocabularyKey Extension { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey PostalAddressLocationId { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey LocationId { get; private set; }


    }
}