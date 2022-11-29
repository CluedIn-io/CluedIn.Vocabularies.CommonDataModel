using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class OrganizationVocabulary : SimpleVocabulary
    {
        public OrganizationVocabulary()
        {
            VocabularyName = "Organization";
            KeyPrefix = "commonDataModel.organization.foundationcommon";
            KeySeparator = ".";
            Grouping = "/Organization";

            AddGroup("Organization Details for FoundationCommon", group =>
            {
			    SchedulingEngine = group.Add(new VocabularyKey(nameof(SchedulingEngine), "Scheduling engine for Appointments and Service Activities", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SchedulingEngine { get; private set; }
    }
}