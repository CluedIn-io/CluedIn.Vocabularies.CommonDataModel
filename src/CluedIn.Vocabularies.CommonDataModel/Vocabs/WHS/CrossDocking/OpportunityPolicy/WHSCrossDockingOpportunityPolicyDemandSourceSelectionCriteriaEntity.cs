using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCrossDockingOpportunityPolicyDemandSourceSelectionCriteriaEntityVocabulary : SimpleVocabulary
    {
        public WHSCrossDockingOpportunityPolicyDemandSourceSelectionCriteriaEntityVocabulary()
        {
            VocabularyName = "WHS Cross Docking Opportunity Policy Demand Source Selection Criteria Entity";
            KeyPrefix = "commonDataModel.whscrossdockingopportunitypolicydemandsourceselectioncriteriaentity";
            KeySeparator = ".";
            Grouping = "/WHSCrossDockingOpportunityPolicyDemandSourceSelectionCriteriaEntity";

            AddGroup("WHSCrossDockingOpportunityPolicyDemandSourceSelectionCriteriaEntity Details", group =>
            {
                DemandSourceTypeCriterion = group.Add(new VocabularyKey(nameof(DemandSourceTypeCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrioritySequenceNumber = group.Add(new VocabularyKey(nameof(PrioritySequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CrossDockingOpportunityPolicyRecId = group.Add(new VocabularyKey(nameof(CrossDockingOpportunityPolicyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MustAppointmentSchedulingHaveAssignedLocationCriterion = group.Add(new VocabularyKey(nameof(MustAppointmentSchedulingHaveAssignedLocationCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CrossDockingPrioritizationStrategy = group.Add(new VocabularyKey(nameof(CrossDockingPrioritizationStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CrossDockingOpportunityPolicyName = group.Add(new VocabularyKey(nameof(CrossDockingOpportunityPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DemandSourceTypeCriterion { get; private set; }
        public VocabularyKey PrioritySequenceNumber { get; private set; }
        public VocabularyKey CrossDockingOpportunityPolicyRecId { get; private set; }
        public VocabularyKey MustAppointmentSchedulingHaveAssignedLocationCriterion { get; private set; }
        public VocabularyKey CrossDockingPrioritizationStrategy { get; private set; }
        public VocabularyKey CrossDockingOpportunityPolicyName { get; private set; }
    }
}