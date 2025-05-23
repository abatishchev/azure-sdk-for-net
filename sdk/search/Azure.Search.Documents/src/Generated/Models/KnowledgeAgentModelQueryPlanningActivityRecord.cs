// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Agents.Models
{
    /// <summary> Represents an LLM query planning activity record. </summary>
    public partial class KnowledgeAgentModelQueryPlanningActivityRecord : KnowledgeAgentActivityRecord
    {
        /// <summary> Initializes a new instance of <see cref="KnowledgeAgentModelQueryPlanningActivityRecord"/>. </summary>
        /// <param name="id"> The ID of the activity record. </param>
        internal KnowledgeAgentModelQueryPlanningActivityRecord(int id) : base(id)
        {
            Type = "ModelQueryPlanning";
        }

        /// <summary> Initializes a new instance of <see cref="KnowledgeAgentModelQueryPlanningActivityRecord"/>. </summary>
        /// <param name="id"> The ID of the activity record. </param>
        /// <param name="type"> The type of the activity record. </param>
        /// <param name="inputTokens"> The number of input tokens for the LLM query planning activity. </param>
        /// <param name="outputTokens"> The number of output tokens for the LLM query planning activity. </param>
        /// <param name="elapsedMs"> The elapsed time in milliseconds for the model activity. </param>
        internal KnowledgeAgentModelQueryPlanningActivityRecord(int id, string type, int? inputTokens, int? outputTokens, int? elapsedMs) : base(id, type)
        {
            InputTokens = inputTokens;
            OutputTokens = outputTokens;
            ElapsedMs = elapsedMs;
            Type = type ?? "ModelQueryPlanning";
        }

        /// <summary> The number of input tokens for the LLM query planning activity. </summary>
        public int? InputTokens { get; }
        /// <summary> The number of output tokens for the LLM query planning activity. </summary>
        public int? OutputTokens { get; }
        /// <summary> The elapsed time in milliseconds for the model activity. </summary>
        public int? ElapsedMs { get; }
    }
}
