using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class OrganizationVocabulary : SimpleVocabulary
    {
        public OrganizationVocabulary()
        {
            VocabularyName = "Organization";
            KeyPrefix = "commonDataModel.organization.scheduling";
            KeySeparator = ".";
            Grouping = "/Organization";

            AddGroup("Organization Details for Scheduling", group =>
            {
			    SchedulingEngine = group.Add(new VocabularyKey(nameof(SchedulingEngine), "Scheduling engine for Appointments and Service Activities", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SchedulingEngine { get; private set; }
    }
}