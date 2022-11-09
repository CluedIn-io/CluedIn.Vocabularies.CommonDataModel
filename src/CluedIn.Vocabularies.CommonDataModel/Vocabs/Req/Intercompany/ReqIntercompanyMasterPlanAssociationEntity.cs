using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqIntercompanyMasterPlanAssociationEntityVocabulary : SimpleVocabulary
    {
        public ReqIntercompanyMasterPlanAssociationEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqIntercompanyMasterPlanAssociationEntity";
            KeyPrefix = "commonDataModel.reqintercompanymasterplanassociationentity";
            KeySeparator = ".";
            Grouping = "/ReqIntercompanyMasterPlanAssociationEntity";

            AddGroup("Common Data Model ReqIntercompanyMasterPlanAssociationEntity Details", group =>
            {
                DownstreamCompanyId = group.Add(new VocabularyKey(nameof(DownstreamCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DownstreamMasterPlanId = group.Add(new VocabularyKey(nameof(DownstreamMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UpstreamCompanyId = group.Add(new VocabularyKey(nameof(UpstreamCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UpstreamMasterPlanId = group.Add(new VocabularyKey(nameof(UpstreamMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DownstreamCompanyId { get; private set; }
public VocabularyKey DownstreamMasterPlanId { get; private set; }
public VocabularyKey UpstreamCompanyId { get; private set; }
public VocabularyKey UpstreamMasterPlanId { get; private set; }


    }
}