using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendChargeVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public VendChargeVendorGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendChargeVendorGroupEntity";
            KeyPrefix = "commonDataModel.vendchargevendorgroupentity";
            KeySeparator = ".";
            Grouping = "/VendChargeVendorGroupEntity";

            AddGroup("Common Data Model VendChargeVendorGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}