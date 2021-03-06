using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductParametersEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductParametersEntity";
            KeyPrefix = "commonDataModel.ecoresproductparametersentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductParametersEntity";

            AddGroup("Common Data Model EcoResProductParametersEntity Details", group =>
            {
                SingletonKey = group.Add(new VocabularyKey(nameof(SingletonKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreProductNumberShownOnForms = group.Add(new VocabularyKey(nameof(AreProductNumberShownOnForms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductEntityAttributeMasterCompanyId = group.Add(new VocabularyKey(nameof(ProductEntityAttributeMasterCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVariantUnitConversionProcesses = group.Add(new VocabularyKey(nameof(ProductVariantUnitConversionProcesses), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SingletonKey { get; private set; }
public VocabularyKey AreProductNumberShownOnForms { get; private set; }
public VocabularyKey ProductEntityAttributeMasterCompanyId { get; private set; }
public VocabularyKey ProductVariantUnitConversionProcesses { get; private set; }


    }
}