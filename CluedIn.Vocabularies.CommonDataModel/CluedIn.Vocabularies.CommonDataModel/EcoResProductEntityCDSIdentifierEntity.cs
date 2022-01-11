using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductEntityCDSIdentifierEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductEntityCDSIdentifierEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductEntityCDSIdentifierEntity";
            KeyPrefix = "commonDataModel.ecoresproductentitycdsidentifierentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductEntityCDSIdentifierEntity";

            AddGroup("Common Data Model EcoResProductEntityCDSIdentifierEntity Details", group =>
            {
                Identifier = group.Add(new VocabularyKey(nameof(Identifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Product = group.Add(new VocabularyKey(nameof(Product), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Scope = group.Add(new VocabularyKey(nameof(Scope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductEntityIdentifierCodeId = group.Add(new VocabularyKey(nameof(ProductEntityIdentifierCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Identifier { get; private set; }
public VocabularyKey Product { get; private set; }
public VocabularyKey ProductNumber { get; private set; }
public VocabularyKey Scope { get; private set; }
public VocabularyKey UnitOfMeasure { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey ProductEntityIdentifierCodeId { get; private set; }


    }
}