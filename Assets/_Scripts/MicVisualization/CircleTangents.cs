using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTangents : MonoBehaviour {
    public AudioPeer _audioPeer;
	public GameObject _circleOutter, _circleInner;

	GameObject[] _circle = new GameObject[1];
	public GameObject _circlePrefab;
	public GameObject _rotationSpawn;

	GameObject[] _pointInnerCircle = new GameObject[1];
	GameObject[] _pointOutterCircle = new GameObject[1];
	GameObject[] _pointSpitBallCircle = new GameObject[1];
	public GameObject _pointPrefab;

	public float[] _distance = new float[1];
	public float[] _radius = new float[1];
	public float[] _angle = new float[1];
    public Vector3 _moveCircleCenterpoint;

    public ParticleSystem _particle0;
    public ParticleSystem _particle1;
    public ParticleSystem _particle2;
    public ParticleSystem _particle3;
    public ParticleSystem _particle4;
    public ParticleSystem _particle5;
    public ParticleSystem _particle6;
    public ParticleSystem _particle7;



    //audio materials
    public Gradient _colorGradient;
	Color[] _color = new Color[1];
	Material[] _material = new Material[1];
	Material[] _materialVortexLine = new Material[1];
	Material[] _materialCircleGround = new Material[1];
	public Material _matOutline, _matOutline2;
	public Material _materialsource, _matVortexSource;
	public float _diffuseColorMultiplier = 1;
	public float _emissionColorMultiplier = 200;
	public float _treshold;
    public float _transparency;
    //public AudioPeer _audioPeer;
    int[] _matRenderQueue = new int[1];
	int[] _matRenderQueueMinus = new int[1];


	// Use this for initialization
	void Start () {


	/*	_diffuseColorMultiplier = 1;
		_matOutline.renderQueue = 4000;
	//	_matOutline.renderQueue = 7000;


		for (int i = 0; i < _circle.Length; i++) {
			//instantiate transform points innercircle
			GameObject _pointInnerInstance = (GameObject)Instantiate (_pointPrefab);
			_pointInnerCircle [i] = _pointInnerInstance;
			_pointInnerInstance.transform.position = _rotationSpawn.transform.position;
			// instantiate transform points outtercircle
			GameObject _pointOutterInstance = (GameObject)Instantiate (_pointPrefab);
			_pointOutterCircle [i] = _pointOutterInstance;
			_pointOutterInstance.transform.position = _rotationSpawn.transform.position;
			//instantiate circles
			GameObject _circleInstance = (GameObject)Instantiate (_circlePrefab);
			_circle [i] = _circleInstance;
			_circleInstance.transform.position = _rotationSpawn.transform.position;
			_circleInstance.transform.eulerAngles = new Vector3 (0, 0, 0);
			_circleInstance.transform.localScale = new Vector3 (1, 1, 1);

			//set materials of circles
			_material[i] = new Material(_materialsource);
			_materialVortexLine[i] = new Material(_matVortexSource);
			_materialCircleGround[i] = new Material(_matOutline);

			_color[i] = _colorGradient.Evaluate((1f / 1f) * i);
			_circleInstance.transform.GetChild(0).GetComponent<MeshRenderer> ().material = _material [i];
			_circleInstance.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer> ().material = _materialVortexLine [i];
			_circleInstance.transform.GetChild(0).GetChild(1).GetComponent<MeshRenderer> ().material = _materialCircleGround [i];


				_matRenderQueue [i] = i;
			_matRenderQueueMinus [i] = i;
			//	_material [i].renderQueue = 3000 + _matRenderQueue [i]; 



			//set all objects as parent to rotation object
			_circleInstance.transform.parent = _rotationSpawn.transform;
			_pointInnerInstance.transform.parent = _rotationSpawn.transform;
			_pointOutterInstance.transform.parent = _rotationSpawn.transform;

			// rotate the object based on the amount of circlepoints
			_rotationSpawn.transform.eulerAngles = new Vector3(0, 12 * i+1, 0);
			// set positions
			_circleInstance.transform.position = Vector3.right * 2.5f;
			_pointInnerInstance.transform.position = Vector3.right * 0.5f;
			_pointOutterInstance.transform.position = Vector3.right * 5f;

			//set to corresponding parents
		
		}
        
		for (int a = 0; a < _circle.Length; a++) {

			_circle[a].transform.parent = null;
			_pointInnerCircle[a].transform.parent = _circleInner.transform;
			_pointOutterCircle[a].transform.parent = _circleOutter.transform;
			}
		_circle [0].transform.eulerAngles = new Vector3 (0, 0, 0);


		for (int i = 0; i < 6; i++) { //spawn the spitballs

			GameObject _pointSpitballInstance = (GameObject)Instantiate (_pointPrefab);
			_pointSpitBallCircle [i] = _pointSpitballInstance;
			_pointSpitballInstance.transform.parent = _rotationSpawn.transform;
			_rotationSpawn.transform.eulerAngles = new Vector3(0, -(1 * i+1), 0);
			_pointSpitballInstance.transform.parent = null;
		}

        */
	}
	
	// Update is called once per frame

	//per punt vanuit point innercircle kijkt ie naar welke afstand tot de outtercircle het kleinst
    /*

	float _renderqueueUpdateTimer;
    public float _amplitudeRenderQueueSpeed;

    */
	void Update () {
		Time.timeScale = 1f + (_audioPeer._AmplitudeBuffer);
        //FindTangentCircle();

        ParticleSystem.MainModule psMain0 = _particle0.main;
        ParticleSystem.MainModule psMain1 = _particle1.main;
        ParticleSystem.MainModule psMain2 = _particle2.main;
        ParticleSystem.MainModule psMain3 = _particle3.main;
        ParticleSystem.MainModule psMain4 = _particle4.main;
        ParticleSystem.MainModule psMain5 = _particle5.main;
        ParticleSystem.MainModule psMain6 = _particle6.main;
        ParticleSystem.MainModule psMain7 = _particle7.main;

        ParticleSystem.NoiseModule Noise0 = _particle0.noise;
        ParticleSystem.NoiseModule Noise1 = _particle1.noise;
        ParticleSystem.NoiseModule Noise2 = _particle2.noise;
        ParticleSystem.NoiseModule Noise3 = _particle3.noise;
        ParticleSystem.NoiseModule Noise4 = _particle4.noise;
        ParticleSystem.NoiseModule Noise5 = _particle5.noise;
        ParticleSystem.NoiseModule Noise6 = _particle6.noise;
        ParticleSystem.NoiseModule Noise7 = _particle7.noise;




        /*_renderqueueUpdateTimer += _audioPeer._AmplitudeBuffer * _amplitudeRenderQueueSpeed;

		if (_renderqueueUpdateTimer > 1) {
			int addQueue = Mathf.FloorToInt (_renderqueueUpdateTimer);
			for (int i = 0; i < 1; i++) {
				_matRenderQueue [i] += addQueue;
				if (_matRenderQueue [i] > 29) {
					_matRenderQueue [i] -= 1;
				}
				_material [i].renderQueue = 3000 + _matRenderQueue [i]; 
			}
			for (int i = 0; i < 1; i++) {
				_matRenderQueueMinus [i] -= addQueue;
				if (_matRenderQueueMinus [i] < 0) {
					_matRenderQueueMinus [i] += 1;
				}
				_material [i].renderQueue = 3000 + _matRenderQueue [i]; 
			}

			_renderqueueUpdateTimer -= addQueue;
            
		}
        */
        //for (int i = 0; i < 8; i++) {
            //_circle[i].transform.LookAt(_circleInner.transform);
            psMain0.simulationSpeed = 1 +_audioPeer._audioBandBuffer64[1 * 6] * _emissionColorMultiplier;
            psMain1.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[2 * 6] * _emissionColorMultiplier;
            psMain2.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[3 * 6] * _emissionColorMultiplier;
            psMain3.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[4 * 6] * _emissionColorMultiplier;
            psMain4.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier;
            psMain5.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier;
            psMain6.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier;
            psMain7.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier;

        
            Noise0.strength = 1 + _audioPeer._audioBandBuffer64[1 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[2 * 6] * _emissionColorMultiplier;
            Noise2.strength = 1 + _audioPeer._audioBandBuffer64[3 * 6] * _emissionColorMultiplier;
            Noise3.strength = 1 + _audioPeer._audioBandBuffer64[4 * 6] * _emissionColorMultiplier;
            Noise4.strength = 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier;
            Noise5.strength = 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier;
            Noise6.strength = 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier;
            Noise7.strength = 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier;

        /*

        _particle4.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier);
        _particle5.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier);
        _particle6.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier);
        _particle7.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier);
        */

        //Color DiffuseColor = new Color ((_color [i].r * _audioPeer._audioBandBuffer64 [i*2]) * _diffuseColorMultiplier, (_color [i].g * _audioPeer._audioBandBuffer64 [i*2]) * _diffuseColorMultiplier, (_color [i].b * _audioPeer._audioBandBuffer64 [i*2]) * _diffuseColorMultiplier, _transparency);
        //_material [_matRenderQueue[i]].SetColor ("_Color", DiffuseColor);
        //Color GroundRoundColor = new Color ((_color [i].r * _audioPeer._audioBandBuffer64 [i*2]) * _diffuseColorMultiplier, (_color [i].g * _audioPeer._audioBandBuffer64 [i*2]) * _diffuseColorMultiplier, (_color [i].b * _audioPeer._audioBandBuffer64 [i*2]) * _diffuseColorMultiplier,0.5f);


        if (_audioPeer._audioBandBuffer64[1] > _treshold)
        {

            psMain0.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[1 * 6] * _emissionColorMultiplier;
            psMain1.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[2 * 6] * _emissionColorMultiplier;
            psMain2.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[3 * 6] * _emissionColorMultiplier;
            psMain3.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[4 * 6] * _emissionColorMultiplier;
            psMain4.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier;
            psMain5.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier;
            psMain6.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier;
            psMain7.simulationSpeed = 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier;


            Noise0.strength = 1 + _audioPeer._audioBandBuffer64[1 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[2 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[3 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[4 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier;
            Noise1.strength = 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier;

            /*
            _particle4.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[5 * 6] * _emissionColorMultiplier);
            _particle5.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[6 * 6] * _emissionColorMultiplier);
            _particle6.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[7 * 6] * _emissionColorMultiplier);
            _particle7.transform.localScale = new Vector3(1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier, 1 + _audioPeer._audioBandBuffer64[8 * 6] * _emissionColorMultiplier);
            */

            //Color EmissionColor = new Color ((_color [i].r * _audioPeer._audioBandBuffer64 [i*2]) * _emissionColorMultiplier, (_color [i].g * _audioPeer._audioBandBuffer64 [i*2]) * _emissionColorMultiplier, (_color [i].b * _audioPeer._audioBandBuffer64 [i*2]) * _emissionColorMultiplier, 1);
            //_materialVortexLine [_matRenderQueueMinus[i]].SetColor ("_EmissionColor", EmissionColor);
            //_materialVortexLine[_matRenderQueueMinus[i]].SetColor ("_Color", EmissionColor);

        } else {
				//Color EmissionColor = new Color (0, 0, 0, 1);
				//_materialVortexLine [_matRenderQueueMinus[i]].SetColor ("_EmissionColor", EmissionColor);
				//_materialVortexLine [_matRenderQueueMinus[i]].SetColor ("_Color", EmissionColor);
			}
		//}
	}
	 float _distanceToInner, _distanceToOutter, _absDifferenceTangentDistant;

	/*void FindTangentCircle()
	{
		for (int a = 0; a < _circle.Length; a++) 
		{
			float _distanceFromOutter = 2.5f;

			for (int i = 0; i < 1; i++) 
			{
				float divide = 1.25f / Mathf.Pow (2, i);
				float radiusInner = _circleInner.transform.localScale.x * 0.5f;
				Vector3 midpoint = new Vector3 (0, 0, 0);
				Vector3 dir = (midpoint - _pointOutterCircle [a].transform.position).normalized;
				Vector3 movePos = _pointOutterCircle [a].transform.position + (dir * _distanceFromOutter);
				Vector3 dirToInner = (_circleInner.transform.position - movePos).normalized;
				_distanceToInner = (Vector3.Distance (_circleInner.transform.position, movePos)) - radiusInner;
				_distanceToOutter = Vector3.Distance (_pointOutterCircle [a].transform.position, movePos);
				_absDifferenceTangentDistant = Mathf.Abs (_distanceToInner - _distanceToOutter);
	
				if (_absDifferenceTangentDistant > 0.01f) 
				{
					if (_distanceToOutter > _distanceToInner) 
					{
						_distanceFromOutter -= divide;
					}
					if (_distanceToOutter < _distanceToInner) 
					{
						_distanceFromOutter += divide;
					}
				} 
				else 
				{
					_circle [a].transform.position = movePos;
					_circle [a].transform.localScale = new Vector3 
						(_distanceToInner * 2, _distanceToInner * 2, _distanceToInner * 2);
					break;
				}
			}
		}
	}
    */
}
