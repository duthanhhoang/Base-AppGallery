using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HoangDT
{
    public class SliderManager : MonoBehaviour
    {
    
        [SerializeField] private Button btnPrev;
        [SerializeField] private Image imgShow;
        [SerializeField] private Button btnNext;
        [Space(10)]
        [SerializeField] private List<Sprite> imagesForShow;
        public int indexImagesForShow = 0;


        private void Start()
        {
            imgShow.sprite = imagesForShow[indexImagesForShow];
        }


        public void OnButtonPrevClicked()
        {
            indexImagesForShow--;

            if (indexImagesForShow < 0)
            {
                indexImagesForShow = imagesForShow.Count - 1;
            }

            imgShow.sprite = imagesForShow[indexImagesForShow];
            
        }

        public void OnButtonNextClicked()
        {
            indexImagesForShow++;

            if (indexImagesForShow > imagesForShow.Count - 1)
            {
                indexImagesForShow = 0;
            }

            imgShow.sprite = imagesForShow[indexImagesForShow];
            Debug.Log(indexImagesForShow);
        }

    }
}