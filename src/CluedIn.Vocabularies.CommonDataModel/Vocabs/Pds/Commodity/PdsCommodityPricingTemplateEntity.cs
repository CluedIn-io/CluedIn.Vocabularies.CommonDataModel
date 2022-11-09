using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsCommodityPricingTemplateEntityVocabulary : SimpleVocabulary
    {
        public PdsCommodityPricingTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsCommodityPricingTemplateEntity";
            KeyPrefix = "commonDataModel.pdscommoditypricingtemplateentity";
            KeySeparator = ".";
            Grouping = "/PdsCommodityPricingTemplateEntity";

            AddGroup("Common Data Model PdsCommodityPricingTemplateEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TemplateId { get; private set; }
public VocabularyKey TemplateDescription { get; private set; }


    }
}