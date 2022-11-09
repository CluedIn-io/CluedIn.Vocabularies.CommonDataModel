using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ClaimVocabulary : SimpleVocabulary
    {
        public ClaimVocabulary()
        {
            VocabularyName = "Common Data Model Claim";
            KeyPrefix = "commonDataModel.claim";
            KeySeparator = ".";
            Grouping = "/Claim";

            AddGroup("Common Data Model Claim Details", group =>
            {
                billablePeriodEnd = group.Add(new VocabularyKey(nameof(billablePeriodEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
billablePeriodStart = group.Add(new VocabularyKey(nameof(billablePeriodStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
claimAccident = group.Add(new VocabularyKey(nameof(claimAccident), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
claimAccidentDate = group.Add(new VocabularyKey(nameof(claimAccidentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
claimId = group.Add(new VocabularyKey(nameof(claimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
employmentImpactEnd = group.Add(new VocabularyKey(nameof(employmentImpactEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
employmentImpactStart = group.Add(new VocabularyKey(nameof(employmentImpactStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
fundsReserve = group.Add(new VocabularyKey(nameof(fundsReserve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
hospitalizationEnd = group.Add(new VocabularyKey(nameof(hospitalizationEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
hospitalizationStart = group.Add(new VocabularyKey(nameof(hospitalizationStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
payeeResourceType = group.Add(new VocabularyKey(nameof(payeeResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
relatedReference = group.Add(new VocabularyKey(nameof(relatedReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
relatedRelationship = group.Add(new VocabularyKey(nameof(relatedRelationship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
subType = group.Add(new VocabularyKey(nameof(subType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
use = group.Add(new VocabularyKey(nameof(use), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey billablePeriodEnd { get; private set; }
public VocabularyKey billablePeriodStart { get; private set; }
public VocabularyKey claimAccident { get; private set; }
public VocabularyKey claimAccidentDate { get; private set; }
public VocabularyKey claimId { get; private set; }
public VocabularyKey employmentImpactEnd { get; private set; }
public VocabularyKey employmentImpactStart { get; private set; }
public VocabularyKey fundsReserve { get; private set; }
public VocabularyKey hospitalizationEnd { get; private set; }
public VocabularyKey hospitalizationStart { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey payeeResourceType { get; private set; }
public VocabularyKey relatedReference { get; private set; }
public VocabularyKey relatedRelationship { get; private set; }
public VocabularyKey subType { get; private set; }
public VocabularyKey use { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}