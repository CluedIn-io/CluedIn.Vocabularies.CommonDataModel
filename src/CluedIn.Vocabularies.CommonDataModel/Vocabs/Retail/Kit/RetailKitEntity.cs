using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailKitEntityVocabulary : SimpleVocabulary
    {
        public RetailKitEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailKitEntity";
            KeyPrefix = "commonDataModel.retailkitentity";
            KeySeparator = ".";
            Grouping = "/RetailKitEntity";

            AddGroup("Common Data Model RetailKitEntity Details", group =>
            {
                DisassemblyAtRegisterAllowed = group.Add(new VocabularyKey(nameof(DisassemblyAtRegisterAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscontinueKit = group.Add(new VocabularyKey(nameof(DiscontinueKit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMaster = group.Add(new VocabularyKey(nameof(ProductMaster), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KitProductNumber = group.Add(new VocabularyKey(nameof(KitProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DisassemblyAtRegisterAllowed { get; private set; }
        public VocabularyKey DiscontinueKit { get; private set; }
        public VocabularyKey ProductMaster { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey KitProductNumber { get; private set; }


    }
}