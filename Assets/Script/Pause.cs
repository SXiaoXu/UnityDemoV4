using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioSource audioBgm;

    public void PauseGame()
    {
        //停止上报游戏时长
        //AntiAddictionUIKit.LeaveGame();

        pauseMenu.SetActive(true);
        //暂停游戏
        Time.timeScale = 0f;
        audioBgm.Pause();
    }
    public void ResumeGame()
    {
        //恢复上报游戏时长
        //AntiAddictionUIKit.EnterGame();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        audioBgm.Play();

    }
    public void GoBackToMenu()
    {
        //退出游戏时，上传排行榜
        updateResults();

    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //更新排行榜收集樱桃数量
    public void updateResults()
    {
        //var currentUser = await TDSUser.GetCurrent();
        //if (null != currentUser)
        //{
        //    int Cherry = PlayerPrefs.GetInt("CherryNum");

        //    Debug.Log("本局游戏收集樱桃的数量是：" + Cherry);
        //    var statistic = new Dictionary<string, double>();
        //    statistic["CherryNum"] = Cherry;
        //    await LCLeaderboard.UpdateStatistics(currentUser, statistic);



        //    //存储分步成就的增长步数
        //    TapAchievement.GrowSteps("Cherry_ytcjz", Cherry);
        //    TapAchievement.GrowSteps("Cherry_qlzf", Cherry);
        //    TapAchievement.GrowSteps("Cherry_ytsgj", Cherry);
        //    TapAchievement.GrowSteps("Cherry_ytdw", Cherry);
        //}
        //else
        //{
        //    //请先登录
        //    Debug.Log("未登录");
        //}
    }

}