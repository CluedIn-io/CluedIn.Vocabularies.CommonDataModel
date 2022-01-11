using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EInvoicePropertyTypeTableEntityVocabulary : SimpleVocabulary
    {
        public EInvoicePropertyTypeTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model EInvoicePropertyTypeTableEntity";
            KeyPrefix = "commonDataModel.einvoicepropertytypetableentity";
            KeySeparator = ".";
            Grouping = "/EInvoicePropertyTypeTableEntity";

            AddGroup("Common Data Model EInvoicePropertyTypeTableEntity Details", group =>
            {
                Custom = group.Add(new VocabularyKey(nameof(Custom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DescriptionLabel = group.Add(new VocabularyKey(nameof(DescriptionLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupDescriptionLabel = group.Add(new VocabularyKey(nameof(GroupDescriptionLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Sorting = group.Add(new VocabularyKey(nameof(Sorting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Custom { get; private set; }
public VocabularyKey DescriptionLabel { get; private set; }
public VocabularyKey GroupDescriptionLabel { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey Sorting { get; private set; }


    }
}