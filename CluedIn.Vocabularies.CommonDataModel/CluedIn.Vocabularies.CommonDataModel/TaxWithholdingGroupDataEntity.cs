using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdingGroupDataEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdingGroupDataEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdingGroupDataEntity";
            KeyPrefix = "commonDataModel.taxwithholdinggroupdataentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdingGroupDataEntity";

            AddGroup("Common Data Model TaxWithholdingGroupDataEntity Details", group =>
            {
                WithholdingTaxCodeId = group.Add(new VocabularyKey(nameof(WithholdingTaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxGroupId = group.Add(new VocabularyKey(nameof(WithholdingTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Exempt = group.Add(new VocabularyKey(nameof(Exempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverlookThreshold = group.Add(new VocabularyKey(nameof(OverlookThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WithholdingTaxCodeId { get; private set; }
public VocabularyKey WithholdingTaxGroupId { get; private set; }
public VocabularyKey Exempt { get; private set; }
public VocabularyKey OverlookThreshold { get; private set; }


    }
}