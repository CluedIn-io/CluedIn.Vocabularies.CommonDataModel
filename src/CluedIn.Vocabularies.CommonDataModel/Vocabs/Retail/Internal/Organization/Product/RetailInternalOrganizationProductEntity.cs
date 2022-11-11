using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInternalOrganizationProductEntityVocabulary : SimpleVocabulary
    {
        public RetailInternalOrganizationProductEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInternalOrganizationProductEntity";
            KeyPrefix = "commonDataModel.retailinternalorganizationproductentity";
            KeySeparator = ".";
            Grouping = "/RetailInternalOrganizationProductEntity";

            AddGroup("Common Data Model RetailInternalOrganizationProductEntity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayProductNumber = group.Add(new VocabularyKey(nameof(DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey DisplayProductNumber { get; private set; }


    }
}