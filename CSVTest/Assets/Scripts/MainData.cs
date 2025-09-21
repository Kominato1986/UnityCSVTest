using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;

public class MainData : MonoBehaviour
{
    List<Offset> offsets = new List<Offset>();
    List<AnimData> animDatas = new List<AnimData>();

    List<Scene> sceneData = new List<Scene>();
    List<Act> acts = new List<Act>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    async void Start()
    {
        //定数系読み込み　今回はオフセットデータ
        string[][] ofset_data = await CsvReader.LoadCsvData("offset.csv");
        if (ofset_data != null)
        {
            for (int i = 1; i < ofset_data.GetLength(0); i++)
            {
                offsets.Add(new Offset(ofset_data[i][0], float.Parse(ofset_data[i][1]), float.Parse(ofset_data[i][2])));
            }
            Debug.Log("オフセットデータのCSVファイルの読み込みが完了しました。");
        }
        else
        {
            Debug.LogError("オフセットデータのCSVデータの取得に失敗しました。");
        }

        //アニメーションデータの読み込み
        string[][] anim_data = await CsvReader.LoadCsvData("animation.csv");
        if (anim_data != null)
        {
            for (int i = 1; i < anim_data.GetLength(0); i++)
            {
                List<string> anim_strings = new List<string>();
                anim_strings = anim_data[i].ToList<string>();
                anim_strings.Remove(anim_data[i][0]);
                animDatas.Add(new AnimData(anim_data[i][0], anim_strings));
            }
            Debug.Log("アニメーションデータのCSVファイルの読み込みが完了しました。");
        }
        else
        {
            Debug.LogError("アニメーションデータのCSVデータの取得に失敗しました。");
        }

        //シーンデータの読み込み
        string[][] scene_data = await CsvReader.LoadCsvData("scene.csv");
        if (scene_data != null)
        {
            for (int i = 1; i < scene_data.GetLength(0); i++)
            {
                sceneData.Add(
                    new Scene
                    {
                        key = scene_data[i][0],
                        start = int.Parse(scene_data[i][1]),
                        end = int.Parse(scene_data[i][2]),
                        ofset = scene_data[i][3],
                        angle = int.Parse(scene_data[i][4]),
                        AnimData = scene_data[i][5]
                    }
                );
            }
            Debug.Log("シーンデータのCSVファイルの読み込みが完了しました。");
        }
        else
        {
            Debug.LogError("シーンデータのCSVデータの取得に失敗しました。");
        }

        //演出データの読み込み
        string[][] act_data = await CsvReader.LoadCsvData("act.csv");
        if (act_data != null)
        {
            for (int i = 1; i < act_data.GetLength(0); i++)
            {
                List<string> strings = new List<string>();
                strings = act_data[i].ToList<string>();
                strings.Remove(act_data[i][0]);
                
                acts.Add(new Act(act_data[i][0], strings));
            }
            
            Debug.Log("演出データのCSVファイルの読み込みが完了しました。");
        }
        else
        {
            Debug.LogError("演出データのCSVデータの取得に失敗しました。");
        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("動作確認用");
    }
}
