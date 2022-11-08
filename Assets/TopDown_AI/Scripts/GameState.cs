using UnityEngine;

namespace TopDown_AI.Scripts
{
    public struct GameState
    {
        public Vector3 playerRelativePos;
        public Vector3 playerPos;

        public Vector3 bulletPos;
        
        public bool playerVisible;
    }
}