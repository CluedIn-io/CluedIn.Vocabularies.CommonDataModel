using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSVendorProductFilterEntityVocabulary : SimpleVocabulary
    {
        public WHSVendorProductFilterEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSVendorProductFilterEntity";
            KeyPrefix = "commonDataModel.whsvendorproductfilterentity";
            KeySeparator = ".";
            Grouping = "/WHSVendorProductFilterEntity";

            AddGroup("Common Data Model WHSVendorProductFilterEntity Details", group =>
            {
                FromDateTime = group.Add(new VocabularyKey(nameof(FromDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceRecordId = group.Add(new VocabularyKey(nameof(ReferenceRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceTableId = group.Add(new VocabularyKey(nameof(ReferenceTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FirstProductFilterCode = group.Add(new VocabularyKey(nameof(FirstProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecondProductFilterCode = group.Add(new VocabularyKey(nameof(SecondProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ThirdProductFilterCode = group.Add(new VocabularyKey(nameof(ThirdProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FourthProductFilterCode = group.Add(new VocabularyKey(nameof(FourthProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FromDateTime { get; private set; }
public VocabularyKey ProductGroupId { get; private set; }
public VocabularyKey ReferenceRecordId { get; private set; }
public VocabularyKey ReferenceTableId { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey FirstProductFilterCode { get; private set; }
public VocabularyKey SecondProductFilterCode { get; private set; }
public VocabularyKey ThirdProductFilterCode { get; private set; }
public VocabularyKey FourthProductFilterCode { get; private set; }


    }
}