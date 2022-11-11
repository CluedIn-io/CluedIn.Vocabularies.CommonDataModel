using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventItemPriceToleranceGroupEntityVocabulary : SimpleVocabulary
    {
        public InventItemPriceToleranceGroupEntityVocabulary()
        {
            VocabularyName = "InventItemPriceToleranceGroupEntity";
            KeyPrefix = "commonDataModel.inventitempricetolerancegroupentity";
            KeySeparator = ".";
            Grouping = "/InventItemPriceToleranceGroupEntity";

            AddGroup("InventItemPriceToleranceGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}