using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Pod : MonoBehaviour
{
    public GameObject pausemenu1;
    public enum PodState{
        ROTATION, //chuyen dong qua lai khi chua cau 
        SHOOT, //khi nhan nut xuong
        REWIND //khi keo len
    }
    #region Serialize
    [SerializeField]
    private float _rotatespeed;
    [SerializeField]
    private float _speed;
    #endregion

    
    private Animator _mainAnim;
    public GameObject _boomAnimator;
    private PodState podState = PodState.ROTATION;
    private float _angle;
    private float _slowDown;
    public int _score = 0;
    //private int _scoreparent;
    private Vector3 _Origin;
    public Transform _Rod;
    private bool _FlagRod;
    [SerializeField] Text _SumScore;
    
    
    private Scene Level1;
    private Scene Level2;
    private Scene Level3;
    private Scene Level4;
    private Scene Level5;
    private Scene Level6;
    private Scene Level7;
    private Scene Level8;
    private Scene end;
    //private Scene end1;   


    void Start()
    {
        Level1 = SceneManager.GetSceneByName("Level1");
        Level2 = SceneManager.GetSceneByName("Level2");
        Level3 = SceneManager.GetSceneByName("Level3");
        Level4 = SceneManager.GetSceneByName("Level4");
        Level5 = SceneManager.GetSceneByName("Level5");
        Level6 = SceneManager.GetSceneByName("Level6");
        Level7 = SceneManager.GetSceneByName("Level7");
        Level8 = SceneManager.GetSceneByName("Level8");
        end = SceneManager.GetSceneByName("end");
        //end1 = SceneManager.GetSceneByName("end 1");
        _score = ScoreHandleController.instance.score;
        StartCoroutine(ChangeScreen());
        
    }

 

    IEnumerator ChangeScreen()
    {

        if (Level1.isLoaded && Level1.IsValid())
        {
            yield return new WaitForSeconds(26);


            GameObject[] level1Objects = Level1.GetRootGameObjects();
            if (level1Objects != null && level1Objects.Length > 0)
            {
                level1Objects[0].SetActive(false);
                SceneManager.LoadScene("Level2");
            }
            if (Level2.isLoaded && Level2.IsValid())
            {
                GameObject[] level2Objects = Level2.GetRootGameObjects();
                if (level2Objects != null && level2Objects.Length > 0)
                {
                    level2Objects[0].SetActive(true);
                }
            }
        }
        //if (Level1.isLoaded && Level1.IsValid())
        //{
        //    yield return new WaitForSeconds(26);


        //    GameObject[] level1Objects = Level1.GetRootGameObjects();
        //    if (level1Objects != null && level1Objects.Length > 0)
        //    {
        //        level1Objects[0].SetActive(false);
        //        SceneManager.LoadScene("end 1");
        //    }

        //}


        if (Level2.isLoaded && Level2.IsValid())
        {
            yield return new WaitForSeconds(26);
            
            GameObject[] level2Objects = Level2.GetRootGameObjects();
            if (level2Objects != null && level2Objects.Length > 0)
            {
                level2Objects[0].SetActive(false);
                SceneManager.LoadScene("Level3");
            }
            if (Level3.isLoaded && Level3.IsValid())
            {
                GameObject[] level3Objects = Level3.GetRootGameObjects();
                if (level3Objects != null && level3Objects.Length > 0)
                {
                    level3Objects[0].SetActive(true);
                }
            }
        }
        if (Level3.isLoaded && Level3.IsValid())
        {
            yield return new WaitForSeconds(26);
            GameObject[] level3Objects = Level3.GetRootGameObjects();
            if (level3Objects != null && level3Objects.Length > 0)
            {
                level3Objects[0].SetActive(false);
                SceneManager.LoadScene("Level4");
            }
            if (Level4.isLoaded && Level4.IsValid())
            {
                GameObject[] level4Objects = Level4.GetRootGameObjects();
                if (level4Objects != null && level4Objects.Length > 0)
                {
                    level4Objects[0].SetActive(true);
                }
            }
        }


        if (Level4.isLoaded && Level4.IsValid())
        {
            yield return new WaitForSeconds(26);
            GameObject[] level4Objects = Level4.GetRootGameObjects();
            if (level4Objects != null && level4Objects.Length > 0)
            {
                level4Objects[0].SetActive(false);
                SceneManager.LoadScene("Level5");
            }
            if (Level5.isLoaded && Level5.IsValid())
            {
                GameObject[] level5Objects = Level5.GetRootGameObjects();
                if (level5Objects != null && level5Objects.Length > 0)
                {
                    level5Objects[0].SetActive(true);
                }
            }
        }
        if (Level5.isLoaded && Level5.IsValid())
        {
            yield return new WaitForSeconds(26);
            GameObject[] level5Objects = Level5.GetRootGameObjects();
            if (level5Objects != null && level5Objects.Length > 0)
            {
                level5Objects[0].SetActive(false);
                SceneManager.LoadScene("end");
            }

        }


        if (Level5.isLoaded && Level5.IsValid())
        {
            yield return new WaitForSeconds(26);
            GameObject[] level5Objects = Level5.GetRootGameObjects();
            if (level5Objects != null && level5Objects.Length > 0)
            {
                level5Objects[0].SetActive(false);
                SceneManager.LoadScene("Level6");
            }
            if (Level6.isLoaded && Level6.IsValid())
            {
                GameObject[] level6Objects = Level6.GetRootGameObjects();
                if (level6Objects != null && level6Objects.Length > 0)
                {
                    level6Objects[0].SetActive(true);
                }
            }
        }
        if (Level6.isLoaded && Level6.IsValid())
        {
            yield return new WaitForSeconds(26);
            GameObject[] level6Objects = Level6.GetRootGameObjects();
            if (level6Objects != null && level6Objects.Length > 0)
            {
                level6Objects[0].SetActive(false);
                SceneManager.LoadScene("Level7");
            }
            if (Level7.isLoaded && Level7.IsValid())
            {
                GameObject[] level7Objects = Level7.GetRootGameObjects();
                if (level7Objects != null && level7Objects.Length > 0)
                {
                    level7Objects[0].SetActive(true);
                }
            }
        }
        if (Level7.isLoaded && Level7.IsValid())
        {
            yield return new WaitForSeconds(26);
            GameObject[] level7Objects = Level7.GetRootGameObjects();
            if (level7Objects != null && level7Objects.Length > 0)
            {
                level7Objects[0].SetActive(false);
                SceneManager.LoadScene("Level8");
            }
            if (Level8.isLoaded && Level8.IsValid())
            {
                GameObject[] level8Objects = Level8.GetRootGameObjects();
                if (level8Objects != null && level8Objects.Length > 0)
                {
                    level8Objects[0].SetActive(true);
                }
            }
        }
        if (Level8.isLoaded && Level8.IsValid())
        {
            yield return new WaitForSeconds(26);
            GameObject[] level8Objects = Level8.GetRootGameObjects();
            if (level8Objects != null && level8Objects.Length > 0)
            {
                level8Objects[0].SetActive(false);
                SceneManager.LoadScene("end");
            }
           
        }


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (_FlagRod) return;
        _FlagRod = true;
        //Transform ts = col.transform;
        _Rod = col.transform;
     
      
        if (_Rod.tag == Config.TAG_BOOM)
        {
            _Rod.tag = this.tag;
            //event boom
            _Rod.GetComponent<Boom>().Bang(_Rod.position);
            //_boomAnimator.Play("Explosion");
        }

        _Rod.SetParent(transform); //pull object up, transform is pod
        //_boomAnimator.Play("Explosion");

        _slowDown = _Rod.GetComponent<Rod>().slowDown; //slow make object
        _score += _Rod.GetComponent<Rod>().score; //advance score
        ScoreHandleController.instance.score = _score;
        Destroy(_Rod.GetComponent<Rod>());
        
        podState = PodState.REWIND;
    }


    void Awake()
    {
        _mainAnim = transform.root.GetComponent<Animator>(); //get render in main class 
        _Origin = transform.position; //position origin
      
    }

    // Update is called once per frame
    void Update()
    {
        switch (podState) {
            case PodState.ROTATION:   
                _mainAnim.Play("Rotation");
                
                if (Input.GetKeyDown(KeyCode.Space))
                    podState = PodState.SHOOT;
                _angle = (_angle + _rotatespeed); // tang goc quay
                //quay mot goc -30 den 90
                if(_angle>105 || _angle<-30)
                    _rotatespeed *= -1; // doi chieu quay
                transform.rotation = Quaternion.AngleAxis(_angle, Vector3.forward);
                //print("Rotation");
                break;
            case PodState.SHOOT:
                _mainAnim.Play("Shoot");
                //if space click then it will jump into shoot
                //go down by the corner
                transform.Translate(Vector3.down * _speed * Time.deltaTime);
                //go up if it touch the object or reach the lenght limit
                if (Mathf.Abs(transform.position.x) > 20 || transform.position.y<  -10 )
                    //charge status
                    podState = PodState.REWIND;
                break;
            case PodState.REWIND:
                _mainAnim.Play("Rewind");
               
                //gioi han cua x1 là -27, y1 là -11 la goc duoi ben trai 
                //this is the opposite
                transform.Translate(Vector3.up * (_speed - _slowDown) * Time.deltaTime);
                if(Mathf.Floor(transform.position.x) == Mathf.Floor(_Origin.x) && Mathf.Floor(transform.position.y) == Mathf.Floor(_Origin.y))
                {
                   
                    if (_Rod != null)
                    {


                        _slowDown = 0; //reset
                        _FlagRod = false; //Destroy object had make pull
                        //sum score
                        
                        _SumScore.text = "Score: " + _score.ToString();

                        Destroy(_Rod.gameObject);
                    }
                    
                    transform.position = _Origin;   
                    podState = PodState.ROTATION;
                }
                    
                break;
            
        }
    }


    //void Update1()
    //{
    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        if (Time.timeScale == 1)
    //        {
    //            pausegame();
    //        }
    //        else
    //        {
    //            resumegame();
    //        }
    //    }
    //}
    public void pausegame()
    {
        Time.timeScale = 0;
        pausemenu1.SetActive(true);
       
    }
    public void resumegame()
    {
        Time.timeScale = 1;
        pausemenu1.SetActive(false);
    }
    public void GoToMenu()
    {

        ScoreHandleController.instance.score = 0;
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
   

}
