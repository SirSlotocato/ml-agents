using System;
using UnityEngine;

namespace Unity.MLAgents
{
    public partial class Agent
    {
        public virtual void CollectDiscreteActionMasks(DiscreteActionMasker actionMasker)
        {
        }

        /// <summary>
        /// This method passes in a float array that is to be populated with actions.  The actions
        /// </summary>
        /// <param name="actionsOut"></param>
        public virtual void Heuristic(float[] actionsOut)
        {
            Debug.LogWarning("Heuristic method called but not implemented. Returning placeholder actions.");
            Array.Clear(actionsOut, 0, actionsOut.Length);
        }

        public virtual void OnActionReceived(float[] vectorAction) {}

        /// <summary>
        /// Returns the last action that was decided on by the Agent.
        /// </summary>
        /// <returns>
        /// The last action that was decided by the Agent (or null if no decision has been made).
        /// </returns>
        /// <seealso cref="OnActionReceived(float[])"/>
        // [Obsolete("GetAction has been deprecated, please use GetStoredActionBuffers, Or GetStoredDiscreteActions.")]
        public float[] GetAction()
        {
            return m_Info.storedVectorActions;
        }

    }
}
