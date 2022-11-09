using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierServiceGroupAssignmentEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierServiceGroupAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSShippingCarrierServiceGroupAssignmentEntity";
            KeyPrefix = "commonDataModel.tmsshippingcarrierservicegroupassignmententity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierServiceGroupAssignmentEntity";

            AddGroup("Common Data Model TMSShippingCarrierServiceGroupAssignmentEntity Details", group =>
            {
                ShippingCarrierServiceGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ShippingCarrierServiceGroupId { get; private set; }
public VocabularyKey ShippingCarrierId { get; private set; }
public VocabularyKey ShippingCarrierServiceId { get; private set; }


    }
}