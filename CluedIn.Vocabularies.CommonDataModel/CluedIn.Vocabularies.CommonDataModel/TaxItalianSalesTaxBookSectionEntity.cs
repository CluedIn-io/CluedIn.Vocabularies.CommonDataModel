using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxItalianSalesTaxBookSectionEntityVocabulary : SimpleVocabulary
    {
        public TaxItalianSalesTaxBookSectionEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxItalianSalesTaxBookSectionEntity";
            KeyPrefix = "commonDataModel.taxitaliansalestaxbooksectionentity";
            KeySeparator = ".";
            Grouping = "/TaxItalianSalesTaxBookSectionEntity";

            AddGroup("Common Data Model TaxItalianSalesTaxBookSectionEntity Details", group =>
            {
                SalesTaxBookSection = group.Add(new VocabularyKey(nameof(SalesTaxBookSection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxBook = group.Add(new VocabularyKey(nameof(SalesTaxBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClosedTo = group.Add(new VocabularyKey(nameof(ClosedTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CloseItalianSalesTaxBookSection = group.Add(new VocabularyKey(nameof(CloseItalianSalesTaxBookSection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesTaxBookSection { get; private set; }
public VocabularyKey SalesTaxBook { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey NumberSequenceCode { get; private set; }
public VocabularyKey ClosedTo { get; private set; }
public VocabularyKey CloseItalianSalesTaxBookSection { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey Voucher { get; private set; }


    }
}