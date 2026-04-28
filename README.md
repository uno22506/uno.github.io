# PdfReviewApp (Prototype Skeleton)

Windows向けのPDF照査支援アプリの初期実装です。

## 構成
- `docs/specification-v1.md`: 仕様書
- `src/PdfReviewApp.Core`: ドメインモデルとインターフェース
- `src/PdfReviewApp.Infrastructure`: 永続化層（スタブ）
- `src/PdfReviewApp.Desktop`: WPF UI層（2ペイン画面、コマンド接続済み）

## 現在の状態
- ツールバー各ボタンは `ICommand` で ViewModel に接続済み
- ステータスバーに操作結果（モード切替・未接続処理案内）を表示
- PDF描画/保存の実体処理は今後実装

## 注意
このリポジトリはプロトタイプ雛形です。環境に .NET SDK がないためビルド確認は未実施です。
