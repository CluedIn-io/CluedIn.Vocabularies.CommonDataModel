using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class ParticipatingOrganizationVocabulary : SimpleVocabulary
    {
        public ParticipatingOrganizationVocabulary()
        {
            VocabularyName = "Participating Organization";
            KeyPrefix = "commonDataModel.participatingorganization.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/ParticipatingOrganization";

            AddGroup("ParticipatingOrganization Details for NonProfitIati", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipatingOrganizationActivityId = group.Add(new VocabularyKey(nameof(ParticipatingOrganizationActivityId), "Participating Organization Activity Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipatingOrganizationId = group.Add(new VocabularyKey(nameof(ParticipatingOrganizationId), "Participating Organization", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationRole = group.Add(new VocabularyKey(nameof(OrganizationRole), "Organization Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ParticipatingOrganizationActivityId { get; private set; }
        public VocabularyKey ParticipatingOrganizationId { get; private set; }
        public VocabularyKey OrganizationRole { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}