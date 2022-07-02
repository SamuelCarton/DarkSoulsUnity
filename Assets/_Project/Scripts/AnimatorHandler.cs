using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamuelCarton{
    public class AnimatorHandler : MonoBehaviour
    {
        public Animator anim;
        int vertical;
        int horizontal;
        public bool canRotate;

        public void Initialize(){
            anim = GetComponent<Animator>();
            vertical = Animator.StringToHash("Vertical");
            horizontal = Animator.StringToHash("Horizontal");
        }

        public void UpdateAnimatorValues(float verticalMovement, float horizontalMouvement){
            #region Vertical
            float v = 0;
            
            if(verticalMovement > 0 && verticalMovement < 0.55f){
                v = 0.5f;
            }
            else if(verticalMovement > 0.55f){
                v = 1;
            }
            else if(verticalMovement < 0 && verticalMovement > -0.55f){
                v = -0.5f;
            }
            else if(verticalMovement < -0.55f){
                v = -1;
            }
            else{
                v = 0;
            }
            #endregion

            #region Horizontal
            float h = 0;
            
            if(horizontalMouvement > 0 && horizontalMouvement < 0.55f){
                h = 0.5f;
            }
            else if(horizontalMouvement > 0.55f){
                h = 1;
            }
            else if(horizontalMouvement < 0 && horizontalMouvement > -0.55f){
                h = -0.5f;
            }
            else if(horizontalMouvement < -0.55f){
                h = -1;
            }
            else{
                h = 0;
            }
            #endregion

            anim.SetFloat(vertical, v, 0.1f, Time.deltaTime);
            anim.SetFloat(vertical, h, 0.1f, Time.deltaTime);
        }

        public void CanRotate(){
            canRotate = true;
        }

        public void StopRotation(){
            canRotate = false;
        }
    }
}