using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeAgreementHeaderExt_RUEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeAgreementHeaderExt_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeAgreementHeaderExt_RUEntity";
            KeyPrefix = "commonDataModel.dimattributeagreementheaderext_ruentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeAgreementHeaderExt_RUEntity";

            AddGroup("Common Data Model DimAttributeAgreementHeaderExt_RUEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}