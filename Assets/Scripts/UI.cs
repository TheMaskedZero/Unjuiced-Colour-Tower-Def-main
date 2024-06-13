using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject startScreen;
    [SerializeField] GameObject blackBox;
    public GameObject tutorialScreen;
    public GameObject tutorialScreen2;

    public static int score;
    public static GameObject showScoreScreen;
    public GameObject scoreScreen;
    public TextMeshProUGUI scoreText;

    public GameObject showRemainingPanel;

    public GameObject levelScreen;
    public static GameObject levelSelectScreen;

    //Ref colour stuff
    [SerializeField] GameObject bannerRefColour1;
    [SerializeField] GameObject bannerRefColour1Part2;
    [SerializeField] GameObject bannerRefColour2;
    [SerializeField] GameObject bannerRefColour2Part2;
    [SerializeField] GameObject stageRefColour;

    Color stageColor;

    List<Vector2> allColourCords = new List<Vector2>();
    List<Vector2> halfAllColours = new List<Vector2>();

    // Start is called before the first frame update
    void Start()
    {
        showRemainingPanel = Spawncolours.showRemainingPanel;
        showScoreScreen = scoreScreen;
        levelSelectScreen = levelScreen;

        string path = Application.persistentDataPath + "/TD no juice Data log.csv";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Level Stage x y Time PositionX PositionY");
        }

        if (File.Exists(path))
        {
            File.AppendAllText(path, "\n");
            File.AppendAllText(path, "new participant");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        startScreen.SetActive(false);
        levelSelectScreen.SetActive(true);
    }

    public void TutorialScreen()
    {
        tutorialScreen.SetActive(true);
        startScreen.SetActive(false);
    }

    public void NextTutorial()
    {
        tutorialScreen.SetActive(false);
        tutorialScreen2.SetActive(true);
    }

    public void BackToStart()
    {
        tutorialScreen.SetActive(false);
        tutorialScreen2.SetActive(false);
        startScreen.SetActive(true);
    }

    public void ScoreScreen()
    {
        showScoreScreen.SetActive(false);
        levelSelectScreen.SetActive(true);
    }

    public void Level1()
    {
        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 1;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.2f, 0.14f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;
        Spawncolours.CIE1931xyCoordinates = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.2f, 0.14f), 0.005f);
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level4Blue()
    {
        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 4;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.2f, 0.14f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;
        Spawncolours.CIE1931xyCoordinates = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.2f, 0.14f), 0.005f);
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level7Blue()
    {
        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 7;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.2f, 0.14f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;
        Spawncolours.CIE1931xyCoordinates = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.2f, 0.14f), 0.005f);
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level2()
    {
        allColourCords.Clear();
        halfAllColours.Clear();

        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 2;
        Spawncolours.stage1 = true;
        
        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.55f, 0.4f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;

        allColourCords = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.55f, 0.4f), 0.0015f);
        for (int i = 0; i < 36; i++)
        {
            halfAllColours.Add(allColourCords[i]);
            allColourCords.Remove(allColourCords[i]);
            Debug.Log(i);
        }
        Spawncolours.CIE1931xyCoordinates = halfAllColours;
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level5Red()
    {
        allColourCords.Clear();
        halfAllColours.Clear();

        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 5;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.55f, 0.4f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;

        allColourCords = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.55f, 0.4f), 0.0015f);
        for (int i = 0; i < 36; i++)
        {
            halfAllColours.Add(allColourCords[i]);
            allColourCords.Remove(allColourCords[i]);
            Debug.Log(i);
        }
        Spawncolours.CIE1931xyCoordinates = halfAllColours;
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level8Red()
    {
        allColourCords.Clear();
        halfAllColours.Clear();

        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 8;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.55f, 0.4f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;

        allColourCords = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.55f, 0.4f), 0.0015f);
        for (int i = 0; i < 36; i++)
        {
            halfAllColours.Add(allColourCords[i]);
            allColourCords.Remove(allColourCords[i]);
            Debug.Log(i);
        }
        Spawncolours.CIE1931xyCoordinates = halfAllColours; 
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level2Second()
    {
        allColourCords.Clear();
        halfAllColours.Clear();

        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 2;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.55f, 0.4f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;

        allColourCords = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.55f, 0.4f), 0.0015f);
        for (int i = 0; i < 36; i++)
        {
            halfAllColours.Add(allColourCords[i]);
            allColourCords.Remove(allColourCords[i]);
            Debug.Log(i);
        }
        Spawncolours.CIE1931xyCoordinates = allColourCords;
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level5RedSecond()
    {
        allColourCords.Clear();
        halfAllColours.Clear();

        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 5;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.55f, 0.4f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;

        allColourCords = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.55f, 0.4f), 0.0015f);
        for (int i = 0; i < 36; i++)
        {
            halfAllColours.Add(allColourCords[i]);
            allColourCords.Remove(allColourCords[i]);
            Debug.Log(i);
        }
        Spawncolours.CIE1931xyCoordinates = allColourCords;
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level8RedSecond()
    {
        allColourCords.Clear();
        halfAllColours.Clear();

        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 8;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.55f, 0.4f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;

        allColourCords = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.55f, 0.4f), 0.0015f);
        for (int i = 0; i < 36; i++)
        {
            halfAllColours.Add(allColourCords[i]);
            allColourCords.Remove(allColourCords[i]);
            Debug.Log(i);
        }
        Spawncolours.CIE1931xyCoordinates = allColourCords;
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level3()
    {
        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 3;
        Spawncolours.stage1 = true;
        
        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.3f, 0.6f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;
        Spawncolours.CIE1931xyCoordinates = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.3f, 0.6f), 0.02f);
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }
    public void Level6Green()
    {
        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 6;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.3f, 0.6f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;
        Spawncolours.CIE1931xyCoordinates = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.3f, 0.6f), 0.02f);
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }

    public void Level9Green()
    {
        showRemainingPanel.SetActive(true);

        score = Random.Range(75, 95);
        scoreText.text = score.ToString() + "%";

        Move.disabledMove = 0;
        Click.disabledClick = 0;

        levelSelectScreen.SetActive(false);
        Spawncolours.timeStart = true;

        Spawncolours.selectedLevel = 9;
        Spawncolours.stage1 = true;

        stageColor = blackBox.GetComponent<ConvertToP3>().Convert(new Vector2(0.3f, 0.6f));
        bannerRefColour1.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2.GetComponent<SpriteRenderer>().color = stageColor;
        stageRefColour.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour1Part2.GetComponent<SpriteRenderer>().color = stageColor;
        bannerRefColour2Part2.GetComponent<SpriteRenderer>().color = stageColor;
        Spawncolours.CIE1931xyCoordinates = blackBox.GetComponent<CalculateCIE1931xyCoordinates>().CreateCoordinates(new Vector2(0.3f, 0.6f), 0.02f);
        Spawncolours.maxSpawn = Spawncolours.CIE1931xyCoordinates.Count;
    }
}
