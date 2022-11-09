using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeProjInvoiceTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeProjInvoiceTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeProjInvoiceTableEntity";
            KeyPrefix = "commonDataModel.dimattributeprojinvoicetableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeProjInvoiceTableEntity";

            AddGroup("Common Data Model DimAttributeProjInvoiceTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}