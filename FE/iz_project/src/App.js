import React from 'react';

// css
import './App.css';

// component
import Button from '@material-ui/core/Button';

function App() {

  return (
    <div className="App">
      {/* 헤더 */}
      <header>
        <img src="/images/Iz_logo.png" className="Iz_logo" alt="logo" />
      </header>
      {/* 물결모양 */}
      <div class="custom-shape-divider-top-1635830287">
        <svg data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1200 120" preserveAspectRatio="none">
          <path d="M985.66,92.83C906.67,72,823.78,31,743.84,14.19c-82.26-17.34-168.06-16.33-250.45.39-57.84,11.73-114,31.07-172,41.86A600.21,600.21,0,0,1,0,27.35V120H1200V95.8C1132.19,118.92,1055.71,111.31,985.66,92.83Z" class="shape-fill"></path>
        </svg>
      </div>
      {/* 아이즈 다운로드 */}
      <div className="Iz_download">
        <div className="how_play">
          <h1>I'z는 어떻게 할 수 있나요?</h1>
          <p>I'z는 VR 기계인 오큘러스 퀘스트 2를 통해 이용 가능합니다.</p>
          <p>1. 아래 버튼을 클릭해 게임을 다운로드 받아주세요!</p>
          <p>2. Oculus Side Quest를 설치 후 다운받은 APK 파일을 업로드합니다.</p>
          <p>3. Oculus Quest로 들어가 앱 > 알 수 없는 출처 > iz-unity.apk파일을 실행합니다.</p>
          <div className="down_button">
            <a href="/files/iz_1.0.0.apk" download>
              <Button variant="contained">iz_1.0.0</Button>
            </a>
          </div>
        </div>
      </div>
      <div class="custom-shape-divider-top-1635908304">
        <svg data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1200 120" preserveAspectRatio="none">
            <path d="M985.66,92.83C906.67,72,823.78,31,743.84,14.19c-82.26-17.34-168.06-16.33-250.45.39-57.84,11.73-114,31.07-172,41.86A600.21,600.21,0,0,1,0,27.35V120H1200V95.8C1132.19,118.92,1055.71,111.31,985.66,92.83Z" class="shape-fill"></path>
        </svg>
      </div>
      {/* 주제선정이유 */}
      <div className="pjt_childabuse">
        <h1>왜 아동학대가 주제인가요?</h1>
        <br></br>
        <div className="child_graph">
          <img src="/images/childabuse_graph.png" className="childabuse_graph" alt="graph" />
        </div>
        <div className="child_table">
          <img src="/images/childabuse_table.png" className="childabuse_table" alt="table" />
        </div>
        <div className="graph_from">
          <p>(출처 : 보건복지부 제공)</p>
        </div>
        <p>아동학대의 피해 건수는 매년 늘어가고 있고, 그중 부모에 의한 학대가 약 80%입니다.</p>
        <p>과연 모든 가해자가 자수를 할까요? 우발적으로 학대를 가한 경우를 제외하고는 거의 자수를 하는 일이 없다고 합니다.</p>
        <p>전문가의 말에 따르면 아동학대는 아직 빙산의 일각일 것이라고 합니다.</p>
        <div className="childabuse_raw">
          <p>2021년 7월 24일</p>
          <h2>영유아 보육법 개정안 통과</h2>
          <h6>아동학대 방지를 위해 영유아 보호자에게 아동학대 예방 교육을 실시할 수 있다.</h6>
        </div>
        <p>또한 영유아 보육법 개정안이 포함되면서 앞으로 미래의 영유아 보호자들은 "아동학대 예방 교육"을 받게 될 것입니다.</p>
        <p>이 법안을 시작으로 다양한 교육 방식과 프로그램이 실시될 것을 예상하며, 이에 맞춰 아이즈 프로젝트를 시작하게 되었습니다.</p>
      </div>
      <div class="custom-shape-divider-bottom-1635915666">
        <svg data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1200 120" preserveAspectRatio="none">
          <path d="M0,0V46.29c47.79,22.2,103.59,32.17,158,28,70.36-5.37,136.33-33.31,206.8-37.5C438.64,32.43,512.34,53.67,583,72.05c69.27,18,138.3,24.88,209.4,13.08,36.15-6,69.85-17.84,104.45-29.34C989.49,25,1113-14.29,1200,52.47V0Z" opacity=".25" class="shape-fill"></path>
          <path d="M0,0V15.81C13,36.92,27.64,56.86,47.69,72.05,99.41,111.27,165,111,224.58,91.58c31.15-10.15,60.09-26.07,89.67-39.8,40.92-19,84.73-46,130.83-49.67,36.26-2.85,70.9,9.42,98.6,31.56,31.77,25.39,62.32,62,103.63,73,40.44,10.79,81.35-6.69,119.13-24.28s75.16-39,116.92-43.05c59.73-5.85,113.28,22.88,168.9,38.84,30.2,8.66,59,6.17,87.09-7.5,22.43-10.89,48-26.93,60.65-49.24V0Z" opacity=".5" class="shape-fill"></path>
          <path d="M0,0V5.63C149.93,59,314.09,71.32,475.83,42.57c43-7.64,84.23-20.12,127.61-26.46,59-8.63,112.48,12.24,165.56,35.4C827.93,77.22,886,95.24,951.2,90c86.53-7,172.46-45.71,248.8-84.81V0Z" class="shape-fill"></path>
        </svg>
      </div>
      {/* 프로젝트 소개 */}
      <div className="whatisIz">
        <div className="Iz_report">    
          <h1>I'z는 어떤 게임인가요?</h1>
          <p>아동학대가 발생한 가정에 방문해 아이의 입장에서 아동학대의 증거가 될만한 물건을 찾아 아이를 구출하는 게임입니다.</p>
          <p>제한 시간에 아동학대의 증거가 될만한 물건을 신중하게 추리해서 증거로 채택해야 아이를 구할 수 있습니다.</p>
          <p>생각지 못한 행동도 아동학대가 될 수 있다는 것을 명심하며 아이의 시선으로 게임에 임해주세요!</p>
          <ul>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">게임 시작</div>
                  <div className="bottom">메인 스테이지</div>
                  <img src="/images/start_main.GIF" className="purpose_img1" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">아이의 집으로 이동</div>
                  <div className="bottom">시티맵</div>
                  <img src="/images/citymap.GIF" className="purpose_img2" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">단서 찾기</div>
                  <div className="bottom">수사관의 시점</div>
                  <img src="/images/start_clue.gif" className="purpose_img3" alt="purpose" />
                </div>
              </div>
            </li>
          </ul>
          <ul>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">정서학대</div>
                  <div className="bottom">수사관의 시점</div>
                  <img src="/images/squid_clue.gif" className="purpose_img4" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">신체학대</div>
                  <div className="bottom">수사관의 시점</div>
                  <img src="/images/bat_clue.gif" className="purpose_img5" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">단서찾기 완료</div>
                  <div className="bottom">수사관의 시점</div>
                  <img src="/images/go_childroom.gif" className="purpose_img6" alt="purpose" />
                </div>
              </div>
            </li>
          </ul>
          <ul>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">아이의 시점으로 전환</div>
                  <div className="bottom">아이의 시점</div>
                  <img src="/images/child_eyes.gif" className="purpose_img4" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">정서학대</div>
                  <div className="bottom">아이의 시점</div>
                  <img src="/images/note_child.gif" className="purpose_img5" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">신체학대</div>
                  <div className="bottom">아이의 시점</div>
                  <img src="/images/bat_child.gif" className="purpose_img6" alt="purpose" />
                </div>
              </div>
            </li>
          </ul>
          <ul>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">학대정황 파악 완료</div>
                  <div className="bottom">아이의 시점</div>
                  <img src="/images/go_police.gif" className="purpose_img4" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">학대에 대한 설명</div>
                  <div className="bottom">아이의 시점</div>
                  <img src="/images/police_end.gif" className="purpose_img5" alt="purpose" />
                </div>
              </div>
            </li>
            <li>
              <div className="gif_list">
                <div className="iz_gif">
                  <div className="top">국내 아동학대 주요 사건</div>
                  <div className="bottom">엔딩크레딧</div>
                  <img src="/images/endingcredit.gif" className="purpose_img6" alt="purpose" />
                </div>
              </div>
            </li>
          </ul>
        </div>
      </div> 
      <div class="custom-shape-divider-top-1635920827">
        <svg data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1200 120" preserveAspectRatio="none">
          <path d="M0,0V46.29c47.79,22.2,103.59,32.17,158,28,70.36-5.37,136.33-33.31,206.8-37.5C438.64,32.43,512.34,53.67,583,72.05c69.27,18,138.3,24.88,209.4,13.08,36.15-6,69.85-17.84,104.45-29.34C989.49,25,1113-14.29,1200,52.47V0Z" opacity=".25" class="shape-fill"></path>
          <path d="M0,0V15.81C13,36.92,27.64,56.86,47.69,72.05,99.41,111.27,165,111,224.58,91.58c31.15-10.15,60.09-26.07,89.67-39.8,40.92-19,84.73-46,130.83-49.67,36.26-2.85,70.9,9.42,98.6,31.56,31.77,25.39,62.32,62,103.63,73,40.44,10.79,81.35-6.69,119.13-24.28s75.16-39,116.92-43.05c59.73-5.85,113.28,22.88,168.9,38.84,30.2,8.66,59,6.17,87.09-7.5,22.43-10.89,48-26.93,60.65-49.24V0Z" opacity=".5" class="shape-fill"></path>
          <path d="M0,0V5.63C149.93,59,314.09,71.32,475.83,42.57c43-7.64,84.23-20.12,127.61-26.46,59-8.63,112.48,12.24,165.56,35.4C827.93,77.22,886,95.24,951.2,90c86.53-7,172.46-45.71,248.8-84.81V0Z" class="shape-fill"></path>
        </svg>
      </div> 
    </div>
  );
}

export default App;