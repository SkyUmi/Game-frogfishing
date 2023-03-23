using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : Rod
{
    
    public ParticleSystem _explo;
    public void Bang(Vector2 pos, bool flag=false)
    {
        var hits = Physics2D.CircleCastAll(pos, 3, Vector2.zero);

        // need a lot property
        // 1. position
        // 2. radius = 3
        // differrence(do lech) or displacement distance from the original
        //_explo.Stop();
        foreach (var hit in hits)
        {
            if(hit.collider == null) continue;
            if(hit.transform.tag == Config.TAG_FROG)
            {
                //delete it
                Destroy(hit.transform.gameObject);
            }
            else if (hit.transform.tag == Config.TAG_COLORFROG)
            {
                Destroy(hit.transform.gameObject);
            }
            else if (hit.transform.tag == Config.TAG_FISH)
            {
                Destroy(hit.transform.gameObject);
            }
            else if (hit.transform.tag == Config.TAG_BIRD)
            {
                Destroy(hit.transform.gameObject);
            }
            else if (hit.transform.tag == Config.TAG_TRASH)
            {
                Destroy(hit.transform.gameObject);
            }
            else if (hit.transform.tag == Config.TAG_BOOM)
            {
                // active boom
                
                hit.transform.tag = Config.TAG_FROG;
                hit.transform.tag = Config.TAG_COLORFROG;
                hit.transform.tag = Config.TAG_FISH;
                hit.transform.tag = Config.TAG_BIRD;
                hit.transform.tag = Config.TAG_TRASH;
                hit.transform.GetComponent<Boom>().Bang(hit.point);

                try
                {
                    if (_explo.isPlaying)
                    {
                        _explo.Stop();

                    }
                    else
                    {
                        _explo.Play();

                    }
                }
                catch { }
                
            }
        }


        
    } 
}
