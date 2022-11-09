using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTmpChannelProductMediaEntityVocabulary : SimpleVocabulary
    {
        public RetailTmpChannelProductMediaEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTmpChannelProductMediaEntity";
            KeyPrefix = "commonDataModel.retailtmpchannelproductmediaentity";
            KeySeparator = ".";
            Grouping = "/RetailTmpChannelProductMediaEntity";

            AddGroup("Common Data Model RetailTmpChannelProductMediaEntity Details", group =>
            {
                InternalOrganization = group.Add(new VocabularyKey(nameof(InternalOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Product = group.Add(new VocabularyKey(nameof(Product), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Url = group.Add(new VocabularyKey(nameof(Url), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssociationStatus = group.Add(new VocabularyKey(nameof(AssociationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InternalOrganization { get; private set; }
public VocabularyKey Product { get; private set; }
public VocabularyKey FileName { get; private set; }
public VocabularyKey Url { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey AssociationStatus { get; private set; }


    }
}